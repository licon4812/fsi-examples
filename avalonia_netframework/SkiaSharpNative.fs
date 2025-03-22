module SkiaSharpNative
open System.Runtime.InteropServices
module SkiaNative =
    [<DllImport("libSkiaSharp", EntryPoint = "KeepSkiaCSymbols")>]
    extern void KeepSkiaCSymbols()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_delete")>]
    extern void gr_backendrendertarget_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_get_backend")>]
    extern void gr_backendrendertarget_get_backend()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_get_gl_framebufferinfo")>]
    extern void gr_backendrendertarget_get_gl_framebufferinfo()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_get_height")>]
    extern void gr_backendrendertarget_get_height()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_get_samples")>]
    extern void gr_backendrendertarget_get_samples()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_get_stencils")>]
    extern void gr_backendrendertarget_get_stencils()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_get_width")>]
    extern void gr_backendrendertarget_get_width()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_is_valid")>]
    extern void gr_backendrendertarget_is_valid()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_new_gl")>]
    extern void gr_backendrendertarget_new_gl()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_new_metal")>]
    extern void gr_backendrendertarget_new_metal()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendrendertarget_new_vulkan")>]
    extern void gr_backendrendertarget_new_vulkan()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendtexture_delete")>]
    extern void gr_backendtexture_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendtexture_get_backend")>]
    extern void gr_backendtexture_get_backend()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendtexture_get_gl_textureinfo")>]
    extern void gr_backendtexture_get_gl_textureinfo()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendtexture_get_height")>]
    extern void gr_backendtexture_get_height()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendtexture_get_width")>]
    extern void gr_backendtexture_get_width()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendtexture_has_mipmaps")>]
    extern void gr_backendtexture_has_mipmaps()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendtexture_is_valid")>]
    extern void gr_backendtexture_is_valid()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendtexture_new_gl")>]
    extern void gr_backendtexture_new_gl()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendtexture_new_metal")>]
    extern void gr_backendtexture_new_metal()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_backendtexture_new_vulkan")>]
    extern void gr_backendtexture_new_vulkan()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_abandon_context")>]
    extern void gr_direct_context_abandon_context()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_dump_memory_statistics")>]
    extern void gr_direct_context_dump_memory_statistics()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_flush")>]
    extern void gr_direct_context_flush()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_flush_and_submit")>]
    extern void gr_direct_context_flush_and_submit()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_flush_image")>]
    extern void gr_direct_context_flush_image()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_flush_surface")>]
    extern void gr_direct_context_flush_surface()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_free_gpu_resources")>]
    extern void gr_direct_context_free_gpu_resources()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_get_resource_cache_limit")>]
    extern void gr_direct_context_get_resource_cache_limit()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_get_resource_cache_usage")>]
    extern void gr_direct_context_get_resource_cache_usage()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_is_abandoned")>]
    extern void gr_direct_context_is_abandoned()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_make_gl")>]
    extern void gr_direct_context_make_gl()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_make_gl_with_options")>]
    extern void gr_direct_context_make_gl_with_options()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_make_metal")>]
    extern void gr_direct_context_make_metal()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_make_metal_with_options")>]
    extern void gr_direct_context_make_metal_with_options()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_make_vulkan")>]
    extern void gr_direct_context_make_vulkan()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_make_vulkan_with_options")>]
    extern void gr_direct_context_make_vulkan_with_options()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_perform_deferred_cleanup")>]
    extern void gr_direct_context_perform_deferred_cleanup()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_purge_unlocked_resources")>]
    extern void gr_direct_context_purge_unlocked_resources()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_purge_unlocked_resources_bytes")>]
    extern void gr_direct_context_purge_unlocked_resources_bytes()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_release_resources_and_abandon_context")>]
    extern void gr_direct_context_release_resources_and_abandon_context()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_reset_context")>]
    extern void gr_direct_context_reset_context()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_set_resource_cache_limit")>]
    extern void gr_direct_context_set_resource_cache_limit()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_direct_context_submit")>]
    extern void gr_direct_context_submit()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_glinterface_assemble_gl_interface")>]
    extern void gr_glinterface_assemble_gl_interface()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_glinterface_assemble_gles_interface")>]
    extern void gr_glinterface_assemble_gles_interface()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_glinterface_assemble_interface")>]
    extern void gr_glinterface_assemble_interface()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_glinterface_assemble_webgl_interface")>]
    extern void gr_glinterface_assemble_webgl_interface()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_glinterface_create_native_interface")>]
    extern void gr_glinterface_create_native_interface()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_glinterface_has_extension")>]
    extern void gr_glinterface_has_extension()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_glinterface_unref")>]
    extern void gr_glinterface_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_glinterface_validate")>]
    extern void gr_glinterface_validate()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_recording_context_get_backend")>]
    extern void gr_recording_context_get_backend()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_recording_context_get_max_surface_sample_count_for_color_type")>]
    extern void gr_recording_context_get_max_surface_sample_count_for_color_type()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_recording_context_is_abandoned")>]
    extern void gr_recording_context_is_abandoned()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_recording_context_max_render_target_size")>]
    extern void gr_recording_context_max_render_target_size()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_recording_context_max_texture_size")>]
    extern void gr_recording_context_max_texture_size()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_recording_context_unref")>]
    extern void gr_recording_context_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_vk_extensions_delete")>]
    extern void gr_vk_extensions_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_vk_extensions_has_extension")>]
    extern void gr_vk_extensions_has_extension()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_vk_extensions_init")>]
    extern void gr_vk_extensions_init()
    [<DllImport("libSkiaSharp", EntryPoint = "gr_vk_extensions_new")>]
    extern void gr_vk_extensions_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_destructor")>]
    extern void sk_bitmap_destructor()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_erase")>]
    extern void sk_bitmap_erase()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_erase_rect")>]
    extern void sk_bitmap_erase_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_extract_alpha")>]
    extern void sk_bitmap_extract_alpha()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_extract_subset")>]
    extern void sk_bitmap_extract_subset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_get_addr")>]
    extern void sk_bitmap_get_addr()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_get_addr_16")>]
    extern void sk_bitmap_get_addr_16()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_get_addr_32")>]
    extern void sk_bitmap_get_addr_32()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_get_addr_8")>]
    extern void sk_bitmap_get_addr_8()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_get_byte_count")>]
    extern void sk_bitmap_get_byte_count()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_get_info")>]
    extern void sk_bitmap_get_info()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_get_pixel_color")>]
    extern void sk_bitmap_get_pixel_color()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_get_pixel_colors")>]
    extern void sk_bitmap_get_pixel_colors()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_get_pixels")>]
    extern void sk_bitmap_get_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_get_row_bytes")>]
    extern void sk_bitmap_get_row_bytes()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_install_pixels")>]
    extern void sk_bitmap_install_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_install_pixels_with_pixmap")>]
    extern void sk_bitmap_install_pixels_with_pixmap()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_is_immutable")>]
    extern void sk_bitmap_is_immutable()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_is_null")>]
    extern void sk_bitmap_is_null()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_make_shader")>]
    extern void sk_bitmap_make_shader()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_new")>]
    extern void sk_bitmap_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_notify_pixels_changed")>]
    extern void sk_bitmap_notify_pixels_changed()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_peek_pixels")>]
    extern void sk_bitmap_peek_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_ready_to_draw")>]
    extern void sk_bitmap_ready_to_draw()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_reset")>]
    extern void sk_bitmap_reset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_set_immutable")>]
    extern void sk_bitmap_set_immutable()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_set_pixels")>]
    extern void sk_bitmap_set_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_swap")>]
    extern void sk_bitmap_swap()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_try_alloc_pixels")>]
    extern void sk_bitmap_try_alloc_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_bitmap_try_alloc_pixels_with_flags")>]
    extern void sk_bitmap_try_alloc_pixels_with_flags()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_blender_new_arithmetic")>]
    extern void sk_blender_new_arithmetic()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_blender_new_mode")>]
    extern void sk_blender_new_mode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_blender_ref")>]
    extern void sk_blender_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_blender_unref")>]
    extern void sk_blender_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_clear")>]
    extern void sk_canvas_clear()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_clear_color4f")>]
    extern void sk_canvas_clear_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_clip_path_with_operation")>]
    extern void sk_canvas_clip_path_with_operation()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_clip_rect_with_operation")>]
    extern void sk_canvas_clip_rect_with_operation()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_clip_region")>]
    extern void sk_canvas_clip_region()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_clip_rrect_with_operation")>]
    extern void sk_canvas_clip_rrect_with_operation()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_concat")>]
    extern void sk_canvas_concat()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_destroy")>]
    extern void sk_canvas_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_discard")>]
    extern void sk_canvas_discard()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_annotation")>]
    extern void sk_canvas_draw_annotation()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_arc")>]
    extern void sk_canvas_draw_arc()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_atlas")>]
    extern void sk_canvas_draw_atlas()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_circle")>]
    extern void sk_canvas_draw_circle()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_color")>]
    extern void sk_canvas_draw_color()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_color4f")>]
    extern void sk_canvas_draw_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_drawable")>]
    extern void sk_canvas_draw_drawable()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_drrect")>]
    extern void sk_canvas_draw_drrect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_image")>]
    extern void sk_canvas_draw_image()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_image_lattice")>]
    extern void sk_canvas_draw_image_lattice()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_image_nine")>]
    extern void sk_canvas_draw_image_nine()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_image_rect")>]
    extern void sk_canvas_draw_image_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_line")>]
    extern void sk_canvas_draw_line()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_link_destination_annotation")>]
    extern void sk_canvas_draw_link_destination_annotation()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_named_destination_annotation")>]
    extern void sk_canvas_draw_named_destination_annotation()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_oval")>]
    extern void sk_canvas_draw_oval()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_paint")>]
    extern void sk_canvas_draw_paint()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_patch")>]
    extern void sk_canvas_draw_patch()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_path")>]
    extern void sk_canvas_draw_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_picture")>]
    extern void sk_canvas_draw_picture()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_point")>]
    extern void sk_canvas_draw_point()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_points")>]
    extern void sk_canvas_draw_points()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_rect")>]
    extern void sk_canvas_draw_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_region")>]
    extern void sk_canvas_draw_region()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_round_rect")>]
    extern void sk_canvas_draw_round_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_rrect")>]
    extern void sk_canvas_draw_rrect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_simple_text")>]
    extern void sk_canvas_draw_simple_text()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_text_blob")>]
    extern void sk_canvas_draw_text_blob()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_url_annotation")>]
    extern void sk_canvas_draw_url_annotation()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_draw_vertices")>]
    extern void sk_canvas_draw_vertices()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_flush")>]
    extern void sk_canvas_flush()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_get_device_clip_bounds")>]
    extern void sk_canvas_get_device_clip_bounds()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_get_local_clip_bounds")>]
    extern void sk_canvas_get_local_clip_bounds()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_get_matrix")>]
    extern void sk_canvas_get_matrix()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_get_save_count")>]
    extern void sk_canvas_get_save_count()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_is_clip_empty")>]
    extern void sk_canvas_is_clip_empty()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_is_clip_rect")>]
    extern void sk_canvas_is_clip_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_new_from_bitmap")>]
    extern void sk_canvas_new_from_bitmap()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_new_from_raster")>]
    extern void sk_canvas_new_from_raster()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_quick_reject")>]
    extern void sk_canvas_quick_reject()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_reset_matrix")>]
    extern void sk_canvas_reset_matrix()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_restore")>]
    extern void sk_canvas_restore()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_restore_to_count")>]
    extern void sk_canvas_restore_to_count()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_rotate_degrees")>]
    extern void sk_canvas_rotate_degrees()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_rotate_radians")>]
    extern void sk_canvas_rotate_radians()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_save")>]
    extern void sk_canvas_save()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_save_layer")>]
    extern void sk_canvas_save_layer()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_scale")>]
    extern void sk_canvas_scale()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_set_matrix")>]
    extern void sk_canvas_set_matrix()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_skew")>]
    extern void sk_canvas_skew()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_canvas_translate")>]
    extern void sk_canvas_translate()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_destroy")>]
    extern void sk_codec_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_encoded_format")>]
    extern void sk_codec_get_encoded_format()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_frame_count")>]
    extern void sk_codec_get_frame_count()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_frame_info")>]
    extern void sk_codec_get_frame_info()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_frame_info_for_index")>]
    extern void sk_codec_get_frame_info_for_index()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_info")>]
    extern void sk_codec_get_info()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_origin")>]
    extern void sk_codec_get_origin()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_pixels")>]
    extern void sk_codec_get_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_repetition_count")>]
    extern void sk_codec_get_repetition_count()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_scaled_dimensions")>]
    extern void sk_codec_get_scaled_dimensions()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_scanline_order")>]
    extern void sk_codec_get_scanline_order()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_scanlines")>]
    extern void sk_codec_get_scanlines()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_get_valid_subset")>]
    extern void sk_codec_get_valid_subset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_incremental_decode")>]
    extern void sk_codec_incremental_decode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_min_buffered_bytes_needed")>]
    extern void sk_codec_min_buffered_bytes_needed()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_new_from_data")>]
    extern void sk_codec_new_from_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_new_from_stream")>]
    extern void sk_codec_new_from_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_next_scanline")>]
    extern void sk_codec_next_scanline()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_output_scanline")>]
    extern void sk_codec_output_scanline()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_skip_scanlines")>]
    extern void sk_codec_skip_scanlines()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_start_incremental_decode")>]
    extern void sk_codec_start_incremental_decode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_codec_start_scanline_decode")>]
    extern void sk_codec_start_scanline_decode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_color4f_from_color")>]
    extern void sk_color4f_from_color()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_color4f_to_color")>]
    extern void sk_color4f_to_color()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_color_get_bit_shift")>]
    extern void sk_color_get_bit_shift()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_color_premultiply")>]
    extern void sk_color_premultiply()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_color_premultiply_array")>]
    extern void sk_color_premultiply_array()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_color_unpremultiply")>]
    extern void sk_color_unpremultiply()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_color_unpremultiply_array")>]
    extern void sk_color_unpremultiply_array()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorfilter_new_color_matrix")>]
    extern void sk_colorfilter_new_color_matrix()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorfilter_new_compose")>]
    extern void sk_colorfilter_new_compose()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorfilter_new_high_contrast")>]
    extern void sk_colorfilter_new_high_contrast()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorfilter_new_lighting")>]
    extern void sk_colorfilter_new_lighting()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorfilter_new_luma_color")>]
    extern void sk_colorfilter_new_luma_color()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorfilter_new_mode")>]
    extern void sk_colorfilter_new_mode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorfilter_new_table")>]
    extern void sk_colorfilter_new_table()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorfilter_new_table_argb")>]
    extern void sk_colorfilter_new_table_argb()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorfilter_unref")>]
    extern void sk_colorfilter_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_equals")>]
    extern void sk_colorspace_equals()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_gamma_close_to_srgb")>]
    extern void sk_colorspace_gamma_close_to_srgb()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_gamma_is_linear")>]
    extern void sk_colorspace_gamma_is_linear()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_icc_profile_delete")>]
    extern void sk_colorspace_icc_profile_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_icc_profile_get_buffer")>]
    extern void sk_colorspace_icc_profile_get_buffer()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_icc_profile_get_to_xyzd50")>]
    extern void sk_colorspace_icc_profile_get_to_xyzd50()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_icc_profile_new")>]
    extern void sk_colorspace_icc_profile_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_icc_profile_parse")>]
    extern void sk_colorspace_icc_profile_parse()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_is_numerical_transfer_fn")>]
    extern void sk_colorspace_is_numerical_transfer_fn()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_is_srgb")>]
    extern void sk_colorspace_is_srgb()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_make_linear_gamma")>]
    extern void sk_colorspace_make_linear_gamma()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_make_srgb_gamma")>]
    extern void sk_colorspace_make_srgb_gamma()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_new_icc")>]
    extern void sk_colorspace_new_icc()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_new_rgb")>]
    extern void sk_colorspace_new_rgb()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_new_srgb")>]
    extern void sk_colorspace_new_srgb()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_new_srgb_linear")>]
    extern void sk_colorspace_new_srgb_linear()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_primaries_to_xyzd50")>]
    extern void sk_colorspace_primaries_to_xyzd50()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_ref")>]
    extern void sk_colorspace_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_to_profile")>]
    extern void sk_colorspace_to_profile()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_to_xyzd50")>]
    extern void sk_colorspace_to_xyzd50()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_transfer_fn_eval")>]
    extern void sk_colorspace_transfer_fn_eval()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_transfer_fn_invert")>]
    extern void sk_colorspace_transfer_fn_invert()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_transfer_fn_named_2dot2")>]
    extern void sk_colorspace_transfer_fn_named_2dot2()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_transfer_fn_named_hlg")>]
    extern void sk_colorspace_transfer_fn_named_hlg()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_transfer_fn_named_linear")>]
    extern void sk_colorspace_transfer_fn_named_linear()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_transfer_fn_named_pq")>]
    extern void sk_colorspace_transfer_fn_named_pq()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_transfer_fn_named_rec2020")>]
    extern void sk_colorspace_transfer_fn_named_rec2020()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_transfer_fn_named_srgb")>]
    extern void sk_colorspace_transfer_fn_named_srgb()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_unref")>]
    extern void sk_colorspace_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_xyz_concat")>]
    extern void sk_colorspace_xyz_concat()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_xyz_invert")>]
    extern void sk_colorspace_xyz_invert()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_xyz_named_adobe_rgb")>]
    extern void sk_colorspace_xyz_named_adobe_rgb()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_xyz_named_display_p3")>]
    extern void sk_colorspace_xyz_named_display_p3()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_xyz_named_rec2020")>]
    extern void sk_colorspace_xyz_named_rec2020()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_xyz_named_srgb")>]
    extern void sk_colorspace_xyz_named_srgb()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colorspace_xyz_named_xyz")>]
    extern void sk_colorspace_xyz_named_xyz()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_colortype_get_default_8888")>]
    extern void sk_colortype_get_default_8888()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_clone")>]
    extern void sk_compatpaint_clone()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_delete")>]
    extern void sk_compatpaint_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_get_filter_quality")>]
    extern void sk_compatpaint_get_filter_quality()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_get_font")>]
    extern void sk_compatpaint_get_font()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_get_lcd_render_text")>]
    extern void sk_compatpaint_get_lcd_render_text()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_get_text_align")>]
    extern void sk_compatpaint_get_text_align()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_get_text_encoding")>]
    extern void sk_compatpaint_get_text_encoding()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_make_font")>]
    extern void sk_compatpaint_make_font()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_new")>]
    extern void sk_compatpaint_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_new_with_font")>]
    extern void sk_compatpaint_new_with_font()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_reset")>]
    extern void sk_compatpaint_reset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_set_filter_quality")>]
    extern void sk_compatpaint_set_filter_quality()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_set_is_antialias")>]
    extern void sk_compatpaint_set_is_antialias()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_set_lcd_render_text")>]
    extern void sk_compatpaint_set_lcd_render_text()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_set_text_align")>]
    extern void sk_compatpaint_set_text_align()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_compatpaint_set_text_encoding")>]
    extern void sk_compatpaint_set_text_encoding()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_get_bytes")>]
    extern void sk_data_get_bytes()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_get_data")>]
    extern void sk_data_get_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_get_size")>]
    extern void sk_data_get_size()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_new_empty")>]
    extern void sk_data_new_empty()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_new_from_file")>]
    extern void sk_data_new_from_file()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_new_from_stream")>]
    extern void sk_data_new_from_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_new_subset")>]
    extern void sk_data_new_subset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_new_uninitialized")>]
    extern void sk_data_new_uninitialized()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_new_with_copy")>]
    extern void sk_data_new_with_copy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_new_with_proc")>]
    extern void sk_data_new_with_proc()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_ref")>]
    extern void sk_data_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_data_unref")>]
    extern void sk_data_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_document_abort")>]
    extern void sk_document_abort()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_document_begin_page")>]
    extern void sk_document_begin_page()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_document_close")>]
    extern void sk_document_close()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_document_create_pdf_from_stream")>]
    extern void sk_document_create_pdf_from_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_document_create_pdf_from_stream_with_metadata")>]
    extern void sk_document_create_pdf_from_stream_with_metadata()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_document_create_xps_from_stream")>]
    extern void sk_document_create_xps_from_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_document_end_page")>]
    extern void sk_document_end_page()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_document_unref")>]
    extern void sk_document_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_drawable_approximate_bytes_used")>]
    extern void sk_drawable_approximate_bytes_used()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_drawable_draw")>]
    extern void sk_drawable_draw()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_drawable_get_bounds")>]
    extern void sk_drawable_get_bounds()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_drawable_get_generation_id")>]
    extern void sk_drawable_get_generation_id()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_drawable_new_picture_snapshot")>]
    extern void sk_drawable_new_picture_snapshot()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_drawable_notify_drawing_changed")>]
    extern void sk_drawable_notify_drawing_changed()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_drawable_unref")>]
    extern void sk_drawable_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_dynamicmemorywstream_copy_to")>]
    extern void sk_dynamicmemorywstream_copy_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_dynamicmemorywstream_destroy")>]
    extern void sk_dynamicmemorywstream_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_dynamicmemorywstream_detach_as_data")>]
    extern void sk_dynamicmemorywstream_detach_as_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_dynamicmemorywstream_detach_as_stream")>]
    extern void sk_dynamicmemorywstream_detach_as_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_dynamicmemorywstream_new")>]
    extern void sk_dynamicmemorywstream_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_dynamicmemorywstream_write_to_stream")>]
    extern void sk_dynamicmemorywstream_write_to_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_filestream_destroy")>]
    extern void sk_filestream_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_filestream_is_valid")>]
    extern void sk_filestream_is_valid()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_filestream_new")>]
    extern void sk_filestream_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_filewstream_destroy")>]
    extern void sk_filewstream_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_filewstream_is_valid")>]
    extern void sk_filewstream_is_valid()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_filewstream_new")>]
    extern void sk_filewstream_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_break_text")>]
    extern void sk_font_break_text()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_delete")>]
    extern void sk_font_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_edging")>]
    extern void sk_font_get_edging()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_hinting")>]
    extern void sk_font_get_hinting()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_metrics")>]
    extern void sk_font_get_metrics()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_path")>]
    extern void sk_font_get_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_paths")>]
    extern void sk_font_get_paths()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_pos")>]
    extern void sk_font_get_pos()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_scale_x")>]
    extern void sk_font_get_scale_x()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_size")>]
    extern void sk_font_get_size()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_skew_x")>]
    extern void sk_font_get_skew_x()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_typeface")>]
    extern void sk_font_get_typeface()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_widths_bounds")>]
    extern void sk_font_get_widths_bounds()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_get_xpos")>]
    extern void sk_font_get_xpos()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_is_baseline_snap")>]
    extern void sk_font_is_baseline_snap()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_is_embedded_bitmaps")>]
    extern void sk_font_is_embedded_bitmaps()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_is_embolden")>]
    extern void sk_font_is_embolden()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_is_force_auto_hinting")>]
    extern void sk_font_is_force_auto_hinting()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_is_linear_metrics")>]
    extern void sk_font_is_linear_metrics()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_is_subpixel")>]
    extern void sk_font_is_subpixel()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_measure_text")>]
    extern void sk_font_measure_text()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_measure_text_no_return")>]
    extern void sk_font_measure_text_no_return()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_new")>]
    extern void sk_font_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_new_with_values")>]
    extern void sk_font_new_with_values()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_baseline_snap")>]
    extern void sk_font_set_baseline_snap()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_edging")>]
    extern void sk_font_set_edging()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_embedded_bitmaps")>]
    extern void sk_font_set_embedded_bitmaps()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_embolden")>]
    extern void sk_font_set_embolden()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_force_auto_hinting")>]
    extern void sk_font_set_force_auto_hinting()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_hinting")>]
    extern void sk_font_set_hinting()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_linear_metrics")>]
    extern void sk_font_set_linear_metrics()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_scale_x")>]
    extern void sk_font_set_scale_x()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_size")>]
    extern void sk_font_set_size()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_skew_x")>]
    extern void sk_font_set_skew_x()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_subpixel")>]
    extern void sk_font_set_subpixel()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_set_typeface")>]
    extern void sk_font_set_typeface()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_text_to_glyphs")>]
    extern void sk_font_text_to_glyphs()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_unichar_to_glyph")>]
    extern void sk_font_unichar_to_glyph()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_font_unichars_to_glyphs")>]
    extern void sk_font_unichars_to_glyphs()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_count_families")>]
    extern void sk_fontmgr_count_families()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_create_default")>]
    extern void sk_fontmgr_create_default()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_create_from_data")>]
    extern void sk_fontmgr_create_from_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_create_from_file")>]
    extern void sk_fontmgr_create_from_file()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_create_from_stream")>]
    extern void sk_fontmgr_create_from_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_create_styleset")>]
    extern void sk_fontmgr_create_styleset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_get_family_name")>]
    extern void sk_fontmgr_get_family_name()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_match_family")>]
    extern void sk_fontmgr_match_family()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_match_family_style")>]
    extern void sk_fontmgr_match_family_style()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_match_family_style_character")>]
    extern void sk_fontmgr_match_family_style_character()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_ref_default")>]
    extern void sk_fontmgr_ref_default()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontmgr_unref")>]
    extern void sk_fontmgr_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyle_delete")>]
    extern void sk_fontstyle_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyle_get_slant")>]
    extern void sk_fontstyle_get_slant()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyle_get_weight")>]
    extern void sk_fontstyle_get_weight()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyle_get_width")>]
    extern void sk_fontstyle_get_width()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyle_new")>]
    extern void sk_fontstyle_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyleset_create_empty")>]
    extern void sk_fontstyleset_create_empty()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyleset_create_typeface")>]
    extern void sk_fontstyleset_create_typeface()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyleset_get_count")>]
    extern void sk_fontstyleset_get_count()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyleset_get_style")>]
    extern void sk_fontstyleset_get_style()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyleset_match_style")>]
    extern void sk_fontstyleset_match_style()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_fontstyleset_unref")>]
    extern void sk_fontstyleset_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_dump_memory_statistics")>]
    extern void sk_graphics_dump_memory_statistics()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_get_font_cache_count_limit")>]
    extern void sk_graphics_get_font_cache_count_limit()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_get_font_cache_count_used")>]
    extern void sk_graphics_get_font_cache_count_used()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_get_font_cache_limit")>]
    extern void sk_graphics_get_font_cache_limit()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_get_font_cache_used")>]
    extern void sk_graphics_get_font_cache_used()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_get_resource_cache_single_allocation_byte_limit")>]
    extern void sk_graphics_get_resource_cache_single_allocation_byte_limit()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_get_resource_cache_total_byte_limit")>]
    extern void sk_graphics_get_resource_cache_total_byte_limit()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_get_resource_cache_total_bytes_used")>]
    extern void sk_graphics_get_resource_cache_total_bytes_used()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_init")>]
    extern void sk_graphics_init()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_purge_all_caches")>]
    extern void sk_graphics_purge_all_caches()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_purge_font_cache")>]
    extern void sk_graphics_purge_font_cache()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_purge_resource_cache")>]
    extern void sk_graphics_purge_resource_cache()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_set_font_cache_count_limit")>]
    extern void sk_graphics_set_font_cache_count_limit()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_set_font_cache_limit")>]
    extern void sk_graphics_set_font_cache_limit()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_set_resource_cache_single_allocation_byte_limit")>]
    extern void sk_graphics_set_resource_cache_single_allocation_byte_limit()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_graphics_set_resource_cache_total_byte_limit")>]
    extern void sk_graphics_set_resource_cache_total_byte_limit()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_get_alpha_type")>]
    extern void sk_image_get_alpha_type()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_get_color_type")>]
    extern void sk_image_get_color_type()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_get_colorspace")>]
    extern void sk_image_get_colorspace()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_get_height")>]
    extern void sk_image_get_height()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_get_unique_id")>]
    extern void sk_image_get_unique_id()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_get_width")>]
    extern void sk_image_get_width()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_is_alpha_only")>]
    extern void sk_image_is_alpha_only()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_is_lazy_generated")>]
    extern void sk_image_is_lazy_generated()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_is_texture_backed")>]
    extern void sk_image_is_texture_backed()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_is_valid")>]
    extern void sk_image_is_valid()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_make_non_texture_image")>]
    extern void sk_image_make_non_texture_image()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_make_raster_image")>]
    extern void sk_image_make_raster_image()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_make_raw_shader")>]
    extern void sk_image_make_raw_shader()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_make_shader")>]
    extern void sk_image_make_shader()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_make_subset")>]
    extern void sk_image_make_subset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_make_subset_raster")>]
    extern void sk_image_make_subset_raster()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_make_texture_image")>]
    extern void sk_image_make_texture_image()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_make_with_filter")>]
    extern void sk_image_make_with_filter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_make_with_filter_raster")>]
    extern void sk_image_make_with_filter_raster()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_new_from_adopted_texture")>]
    extern void sk_image_new_from_adopted_texture()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_new_from_bitmap")>]
    extern void sk_image_new_from_bitmap()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_new_from_encoded")>]
    extern void sk_image_new_from_encoded()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_new_from_picture")>]
    extern void sk_image_new_from_picture()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_new_from_texture")>]
    extern void sk_image_new_from_texture()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_new_raster")>]
    extern void sk_image_new_raster()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_new_raster_copy")>]
    extern void sk_image_new_raster_copy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_new_raster_copy_with_pixmap")>]
    extern void sk_image_new_raster_copy_with_pixmap()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_new_raster_data")>]
    extern void sk_image_new_raster_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_peek_pixels")>]
    extern void sk_image_peek_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_read_pixels")>]
    extern void sk_image_read_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_read_pixels_into_pixmap")>]
    extern void sk_image_read_pixels_into_pixmap()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_ref")>]
    extern void sk_image_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_ref_encoded")>]
    extern void sk_image_ref_encoded()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_scale_pixels")>]
    extern void sk_image_scale_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_image_unref")>]
    extern void sk_image_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_arithmetic")>]
    extern void sk_imagefilter_new_arithmetic()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_blend")>]
    extern void sk_imagefilter_new_blend()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_blender")>]
    extern void sk_imagefilter_new_blender()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_blur")>]
    extern void sk_imagefilter_new_blur()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_color_filter")>]
    extern void sk_imagefilter_new_color_filter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_compose")>]
    extern void sk_imagefilter_new_compose()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_dilate")>]
    extern void sk_imagefilter_new_dilate()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_displacement_map_effect")>]
    extern void sk_imagefilter_new_displacement_map_effect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_distant_lit_diffuse")>]
    extern void sk_imagefilter_new_distant_lit_diffuse()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_distant_lit_specular")>]
    extern void sk_imagefilter_new_distant_lit_specular()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_drop_shadow")>]
    extern void sk_imagefilter_new_drop_shadow()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_drop_shadow_only")>]
    extern void sk_imagefilter_new_drop_shadow_only()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_erode")>]
    extern void sk_imagefilter_new_erode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_image")>]
    extern void sk_imagefilter_new_image()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_image_simple")>]
    extern void sk_imagefilter_new_image_simple()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_magnifier")>]
    extern void sk_imagefilter_new_magnifier()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_matrix_convolution")>]
    extern void sk_imagefilter_new_matrix_convolution()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_matrix_transform")>]
    extern void sk_imagefilter_new_matrix_transform()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_merge")>]
    extern void sk_imagefilter_new_merge()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_merge_simple")>]
    extern void sk_imagefilter_new_merge_simple()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_offset")>]
    extern void sk_imagefilter_new_offset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_picture")>]
    extern void sk_imagefilter_new_picture()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_picture_with_rect")>]
    extern void sk_imagefilter_new_picture_with_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_point_lit_diffuse")>]
    extern void sk_imagefilter_new_point_lit_diffuse()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_point_lit_specular")>]
    extern void sk_imagefilter_new_point_lit_specular()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_shader")>]
    extern void sk_imagefilter_new_shader()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_spot_lit_diffuse")>]
    extern void sk_imagefilter_new_spot_lit_diffuse()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_spot_lit_specular")>]
    extern void sk_imagefilter_new_spot_lit_specular()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_new_tile")>]
    extern void sk_imagefilter_new_tile()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_imagefilter_unref")>]
    extern void sk_imagefilter_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_jpegencoder_encode")>]
    extern void sk_jpegencoder_encode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_linker_keep_alive")>]
    extern void sk_linker_keep_alive()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_manageddrawable_new")>]
    extern void sk_manageddrawable_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_manageddrawable_set_procs")>]
    extern void sk_manageddrawable_set_procs()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_manageddrawable_unref")>]
    extern void sk_manageddrawable_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_managedstream_destroy")>]
    extern void sk_managedstream_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_managedstream_new")>]
    extern void sk_managedstream_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_managedstream_set_procs")>]
    extern void sk_managedstream_set_procs()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_managedtracememorydump_delete")>]
    extern void sk_managedtracememorydump_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_managedtracememorydump_new")>]
    extern void sk_managedtracememorydump_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_managedtracememorydump_set_procs")>]
    extern void sk_managedtracememorydump_set_procs()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_managedwstream_destroy")>]
    extern void sk_managedwstream_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_managedwstream_new")>]
    extern void sk_managedwstream_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_managedwstream_set_procs")>]
    extern void sk_managedwstream_set_procs()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_maskfilter_new_blur")>]
    extern void sk_maskfilter_new_blur()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_maskfilter_new_blur_with_flags")>]
    extern void sk_maskfilter_new_blur_with_flags()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_maskfilter_new_clip")>]
    extern void sk_maskfilter_new_clip()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_maskfilter_new_gamma")>]
    extern void sk_maskfilter_new_gamma()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_maskfilter_new_shader")>]
    extern void sk_maskfilter_new_shader()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_maskfilter_new_table")>]
    extern void sk_maskfilter_new_table()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_maskfilter_ref")>]
    extern void sk_maskfilter_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_maskfilter_unref")>]
    extern void sk_maskfilter_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_matrix_concat")>]
    extern void sk_matrix_concat()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_matrix_map_points")>]
    extern void sk_matrix_map_points()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_matrix_map_radius")>]
    extern void sk_matrix_map_radius()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_matrix_map_rect")>]
    extern void sk_matrix_map_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_matrix_map_vector")>]
    extern void sk_matrix_map_vector()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_matrix_map_vectors")>]
    extern void sk_matrix_map_vectors()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_matrix_map_xy")>]
    extern void sk_matrix_map_xy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_matrix_post_concat")>]
    extern void sk_matrix_post_concat()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_matrix_pre_concat")>]
    extern void sk_matrix_pre_concat()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_matrix_try_invert")>]
    extern void sk_matrix_try_invert()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_memorystream_destroy")>]
    extern void sk_memorystream_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_memorystream_new")>]
    extern void sk_memorystream_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_memorystream_new_with_data")>]
    extern void sk_memorystream_new_with_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_memorystream_new_with_length")>]
    extern void sk_memorystream_new_with_length()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_memorystream_new_with_skdata")>]
    extern void sk_memorystream_new_with_skdata()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_memorystream_set_memory")>]
    extern void sk_memorystream_set_memory()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nodraw_canvas_destroy")>]
    extern void sk_nodraw_canvas_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nodraw_canvas_new")>]
    extern void sk_nodraw_canvas_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nvrefcnt_get_ref_count")>]
    extern void sk_nvrefcnt_get_ref_count()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nvrefcnt_safe_ref")>]
    extern void sk_nvrefcnt_safe_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nvrefcnt_safe_unref")>]
    extern void sk_nvrefcnt_safe_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nvrefcnt_unique")>]
    extern void sk_nvrefcnt_unique()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nway_canvas_add_canvas")>]
    extern void sk_nway_canvas_add_canvas()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nway_canvas_destroy")>]
    extern void sk_nway_canvas_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nway_canvas_new")>]
    extern void sk_nway_canvas_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nway_canvas_remove_all")>]
    extern void sk_nway_canvas_remove_all()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_nway_canvas_remove_canvas")>]
    extern void sk_nway_canvas_remove_canvas()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_opbuilder_add")>]
    extern void sk_opbuilder_add()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_opbuilder_destroy")>]
    extern void sk_opbuilder_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_opbuilder_new")>]
    extern void sk_opbuilder_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_opbuilder_resolve")>]
    extern void sk_opbuilder_resolve()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_overdraw_canvas_destroy")>]
    extern void sk_overdraw_canvas_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_overdraw_canvas_new")>]
    extern void sk_overdraw_canvas_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_clone")>]
    extern void sk_paint_clone()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_delete")>]
    extern void sk_paint_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_blender")>]
    extern void sk_paint_get_blender()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_blendmode")>]
    extern void sk_paint_get_blendmode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_color")>]
    extern void sk_paint_get_color()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_color4f")>]
    extern void sk_paint_get_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_colorfilter")>]
    extern void sk_paint_get_colorfilter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_fill_path")>]
    extern void sk_paint_get_fill_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_imagefilter")>]
    extern void sk_paint_get_imagefilter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_maskfilter")>]
    extern void sk_paint_get_maskfilter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_path_effect")>]
    extern void sk_paint_get_path_effect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_shader")>]
    extern void sk_paint_get_shader()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_stroke_cap")>]
    extern void sk_paint_get_stroke_cap()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_stroke_join")>]
    extern void sk_paint_get_stroke_join()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_stroke_miter")>]
    extern void sk_paint_get_stroke_miter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_stroke_width")>]
    extern void sk_paint_get_stroke_width()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_get_style")>]
    extern void sk_paint_get_style()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_is_antialias")>]
    extern void sk_paint_is_antialias()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_is_dither")>]
    extern void sk_paint_is_dither()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_new")>]
    extern void sk_paint_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_reset")>]
    extern void sk_paint_reset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_antialias")>]
    extern void sk_paint_set_antialias()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_blender")>]
    extern void sk_paint_set_blender()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_blendmode")>]
    extern void sk_paint_set_blendmode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_color")>]
    extern void sk_paint_set_color()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_color4f")>]
    extern void sk_paint_set_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_colorfilter")>]
    extern void sk_paint_set_colorfilter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_dither")>]
    extern void sk_paint_set_dither()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_imagefilter")>]
    extern void sk_paint_set_imagefilter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_maskfilter")>]
    extern void sk_paint_set_maskfilter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_path_effect")>]
    extern void sk_paint_set_path_effect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_shader")>]
    extern void sk_paint_set_shader()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_stroke_cap")>]
    extern void sk_paint_set_stroke_cap()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_stroke_join")>]
    extern void sk_paint_set_stroke_join()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_stroke_miter")>]
    extern void sk_paint_set_stroke_miter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_stroke_width")>]
    extern void sk_paint_set_stroke_width()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_paint_set_style")>]
    extern void sk_paint_set_style()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_arc")>]
    extern void sk_path_add_arc()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_circle")>]
    extern void sk_path_add_circle()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_oval")>]
    extern void sk_path_add_oval()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_path")>]
    extern void sk_path_add_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_path_matrix")>]
    extern void sk_path_add_path_matrix()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_path_offset")>]
    extern void sk_path_add_path_offset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_path_reverse")>]
    extern void sk_path_add_path_reverse()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_poly")>]
    extern void sk_path_add_poly()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_rect")>]
    extern void sk_path_add_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_rect_start")>]
    extern void sk_path_add_rect_start()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_rounded_rect")>]
    extern void sk_path_add_rounded_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_rrect")>]
    extern void sk_path_add_rrect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_add_rrect_start")>]
    extern void sk_path_add_rrect_start()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_arc_to")>]
    extern void sk_path_arc_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_arc_to_with_oval")>]
    extern void sk_path_arc_to_with_oval()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_arc_to_with_points")>]
    extern void sk_path_arc_to_with_points()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_clone")>]
    extern void sk_path_clone()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_close")>]
    extern void sk_path_close()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_compute_tight_bounds")>]
    extern void sk_path_compute_tight_bounds()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_conic_to")>]
    extern void sk_path_conic_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_contains")>]
    extern void sk_path_contains()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_convert_conic_to_quads")>]
    extern void sk_path_convert_conic_to_quads()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_count_points")>]
    extern void sk_path_count_points()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_count_verbs")>]
    extern void sk_path_count_verbs()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_create_iter")>]
    extern void sk_path_create_iter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_create_rawiter")>]
    extern void sk_path_create_rawiter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_cubic_to")>]
    extern void sk_path_cubic_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_delete")>]
    extern void sk_path_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_effect_create_1d_path")>]
    extern void sk_path_effect_create_1d_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_effect_create_2d_line")>]
    extern void sk_path_effect_create_2d_line()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_effect_create_2d_path")>]
    extern void sk_path_effect_create_2d_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_effect_create_compose")>]
    extern void sk_path_effect_create_compose()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_effect_create_corner")>]
    extern void sk_path_effect_create_corner()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_effect_create_dash")>]
    extern void sk_path_effect_create_dash()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_effect_create_discrete")>]
    extern void sk_path_effect_create_discrete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_effect_create_sum")>]
    extern void sk_path_effect_create_sum()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_effect_create_trim")>]
    extern void sk_path_effect_create_trim()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_effect_unref")>]
    extern void sk_path_effect_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_get_bounds")>]
    extern void sk_path_get_bounds()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_get_filltype")>]
    extern void sk_path_get_filltype()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_get_last_point")>]
    extern void sk_path_get_last_point()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_get_point")>]
    extern void sk_path_get_point()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_get_points")>]
    extern void sk_path_get_points()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_get_segment_masks")>]
    extern void sk_path_get_segment_masks()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_is_convex")>]
    extern void sk_path_is_convex()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_is_line")>]
    extern void sk_path_is_line()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_is_oval")>]
    extern void sk_path_is_oval()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_is_rect")>]
    extern void sk_path_is_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_is_rrect")>]
    extern void sk_path_is_rrect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_iter_conic_weight")>]
    extern void sk_path_iter_conic_weight()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_iter_destroy")>]
    extern void sk_path_iter_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_iter_is_close_line")>]
    extern void sk_path_iter_is_close_line()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_iter_is_closed_contour")>]
    extern void sk_path_iter_is_closed_contour()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_iter_next")>]
    extern void sk_path_iter_next()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_line_to")>]
    extern void sk_path_line_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_move_to")>]
    extern void sk_path_move_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_new")>]
    extern void sk_path_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_parse_svg_string")>]
    extern void sk_path_parse_svg_string()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_quad_to")>]
    extern void sk_path_quad_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rarc_to")>]
    extern void sk_path_rarc_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rawiter_conic_weight")>]
    extern void sk_path_rawiter_conic_weight()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rawiter_destroy")>]
    extern void sk_path_rawiter_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rawiter_next")>]
    extern void sk_path_rawiter_next()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rawiter_peek")>]
    extern void sk_path_rawiter_peek()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rconic_to")>]
    extern void sk_path_rconic_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rcubic_to")>]
    extern void sk_path_rcubic_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_reset")>]
    extern void sk_path_reset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rewind")>]
    extern void sk_path_rewind()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rline_to")>]
    extern void sk_path_rline_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rmove_to")>]
    extern void sk_path_rmove_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_rquad_to")>]
    extern void sk_path_rquad_to()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_set_filltype")>]
    extern void sk_path_set_filltype()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_to_svg_string")>]
    extern void sk_path_to_svg_string()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_transform")>]
    extern void sk_path_transform()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_path_transform_to_dest")>]
    extern void sk_path_transform_to_dest()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathmeasure_destroy")>]
    extern void sk_pathmeasure_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathmeasure_get_length")>]
    extern void sk_pathmeasure_get_length()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathmeasure_get_matrix")>]
    extern void sk_pathmeasure_get_matrix()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathmeasure_get_pos_tan")>]
    extern void sk_pathmeasure_get_pos_tan()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathmeasure_get_segment")>]
    extern void sk_pathmeasure_get_segment()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathmeasure_is_closed")>]
    extern void sk_pathmeasure_is_closed()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathmeasure_new")>]
    extern void sk_pathmeasure_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathmeasure_new_with_path")>]
    extern void sk_pathmeasure_new_with_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathmeasure_next_contour")>]
    extern void sk_pathmeasure_next_contour()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathmeasure_set_path")>]
    extern void sk_pathmeasure_set_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathop_as_winding")>]
    extern void sk_pathop_as_winding()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathop_op")>]
    extern void sk_pathop_op()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathop_simplify")>]
    extern void sk_pathop_simplify()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pathop_tight_bounds")>]
    extern void sk_pathop_tight_bounds()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_approximate_bytes_used")>]
    extern void sk_picture_approximate_bytes_used()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_approximate_op_count")>]
    extern void sk_picture_approximate_op_count()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_deserialize_from_data")>]
    extern void sk_picture_deserialize_from_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_deserialize_from_memory")>]
    extern void sk_picture_deserialize_from_memory()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_deserialize_from_stream")>]
    extern void sk_picture_deserialize_from_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_get_cull_rect")>]
    extern void sk_picture_get_cull_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_get_recording_canvas")>]
    extern void sk_picture_get_recording_canvas()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_get_unique_id")>]
    extern void sk_picture_get_unique_id()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_make_shader")>]
    extern void sk_picture_make_shader()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_playback")>]
    extern void sk_picture_playback()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_recorder_begin_recording")>]
    extern void sk_picture_recorder_begin_recording()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_recorder_begin_recording_with_bbh_factory")>]
    extern void sk_picture_recorder_begin_recording_with_bbh_factory()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_recorder_delete")>]
    extern void sk_picture_recorder_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_recorder_end_recording")>]
    extern void sk_picture_recorder_end_recording()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_recorder_end_recording_as_drawable")>]
    extern void sk_picture_recorder_end_recording_as_drawable()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_recorder_new")>]
    extern void sk_picture_recorder_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_ref")>]
    extern void sk_picture_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_serialize_to_data")>]
    extern void sk_picture_serialize_to_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_serialize_to_stream")>]
    extern void sk_picture_serialize_to_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_picture_unref")>]
    extern void sk_picture_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_compute_is_opaque")>]
    extern void sk_pixmap_compute_is_opaque()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_destructor")>]
    extern void sk_pixmap_destructor()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_erase_color")>]
    extern void sk_pixmap_erase_color()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_erase_color4f")>]
    extern void sk_pixmap_erase_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_extract_subset")>]
    extern void sk_pixmap_extract_subset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_get_colorspace")>]
    extern void sk_pixmap_get_colorspace()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_get_info")>]
    extern void sk_pixmap_get_info()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_get_pixel_alphaf")>]
    extern void sk_pixmap_get_pixel_alphaf()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_get_pixel_color")>]
    extern void sk_pixmap_get_pixel_color()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_get_pixel_color4f")>]
    extern void sk_pixmap_get_pixel_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_get_row_bytes")>]
    extern void sk_pixmap_get_row_bytes()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_get_writable_addr")>]
    extern void sk_pixmap_get_writable_addr()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_get_writeable_addr_with_xy")>]
    extern void sk_pixmap_get_writeable_addr_with_xy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_new")>]
    extern void sk_pixmap_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_new_with_params")>]
    extern void sk_pixmap_new_with_params()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_read_pixels")>]
    extern void sk_pixmap_read_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_reset")>]
    extern void sk_pixmap_reset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_reset_with_params")>]
    extern void sk_pixmap_reset_with_params()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_scale_pixels")>]
    extern void sk_pixmap_scale_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pixmap_set_colorspace")>]
    extern void sk_pixmap_set_colorspace()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_pngencoder_encode")>]
    extern void sk_pngencoder_encode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_refcnt_get_ref_count")>]
    extern void sk_refcnt_get_ref_count()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_refcnt_safe_ref")>]
    extern void sk_refcnt_safe_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_refcnt_safe_unref")>]
    extern void sk_refcnt_safe_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_refcnt_unique")>]
    extern void sk_refcnt_unique()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_cliperator_delete")>]
    extern void sk_region_cliperator_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_cliperator_done")>]
    extern void sk_region_cliperator_done()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_cliperator_new")>]
    extern void sk_region_cliperator_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_cliperator_next")>]
    extern void sk_region_cliperator_next()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_cliperator_rect")>]
    extern void sk_region_cliperator_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_contains")>]
    extern void sk_region_contains()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_contains_point")>]
    extern void sk_region_contains_point()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_contains_rect")>]
    extern void sk_region_contains_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_delete")>]
    extern void sk_region_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_get_boundary_path")>]
    extern void sk_region_get_boundary_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_get_bounds")>]
    extern void sk_region_get_bounds()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_intersects")>]
    extern void sk_region_intersects()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_intersects_rect")>]
    extern void sk_region_intersects_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_is_complex")>]
    extern void sk_region_is_complex()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_is_empty")>]
    extern void sk_region_is_empty()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_is_rect")>]
    extern void sk_region_is_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_iterator_delete")>]
    extern void sk_region_iterator_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_iterator_done")>]
    extern void sk_region_iterator_done()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_iterator_new")>]
    extern void sk_region_iterator_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_iterator_next")>]
    extern void sk_region_iterator_next()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_iterator_rect")>]
    extern void sk_region_iterator_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_iterator_rewind")>]
    extern void sk_region_iterator_rewind()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_new")>]
    extern void sk_region_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_op")>]
    extern void sk_region_op()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_op_rect")>]
    extern void sk_region_op_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_quick_contains")>]
    extern void sk_region_quick_contains()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_quick_reject")>]
    extern void sk_region_quick_reject()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_quick_reject_rect")>]
    extern void sk_region_quick_reject_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_set_empty")>]
    extern void sk_region_set_empty()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_set_path")>]
    extern void sk_region_set_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_set_rect")>]
    extern void sk_region_set_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_set_rects")>]
    extern void sk_region_set_rects()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_set_region")>]
    extern void sk_region_set_region()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_spanerator_delete")>]
    extern void sk_region_spanerator_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_spanerator_new")>]
    extern void sk_region_spanerator_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_spanerator_next")>]
    extern void sk_region_spanerator_next()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_region_translate")>]
    extern void sk_region_translate()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_contains")>]
    extern void sk_rrect_contains()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_delete")>]
    extern void sk_rrect_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_get_height")>]
    extern void sk_rrect_get_height()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_get_radii")>]
    extern void sk_rrect_get_radii()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_get_rect")>]
    extern void sk_rrect_get_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_get_type")>]
    extern void sk_rrect_get_type()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_get_width")>]
    extern void sk_rrect_get_width()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_inset")>]
    extern void sk_rrect_inset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_is_valid")>]
    extern void sk_rrect_is_valid()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_new")>]
    extern void sk_rrect_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_new_copy")>]
    extern void sk_rrect_new_copy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_offset")>]
    extern void sk_rrect_offset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_outset")>]
    extern void sk_rrect_outset()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_set_empty")>]
    extern void sk_rrect_set_empty()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_set_nine_patch")>]
    extern void sk_rrect_set_nine_patch()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_set_oval")>]
    extern void sk_rrect_set_oval()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_set_rect")>]
    extern void sk_rrect_set_rect()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_set_rect_radii")>]
    extern void sk_rrect_set_rect_radii()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_set_rect_xy")>]
    extern void sk_rrect_set_rect_xy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rrect_transform")>]
    extern void sk_rrect_transform()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rtree_factory_delete")>]
    extern void sk_rtree_factory_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_rtree_factory_new")>]
    extern void sk_rtree_factory_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_get_child_from_index")>]
    extern void sk_runtimeeffect_get_child_from_index()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_get_child_from_name")>]
    extern void sk_runtimeeffect_get_child_from_name()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_get_child_name")>]
    extern void sk_runtimeeffect_get_child_name()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_get_children_size")>]
    extern void sk_runtimeeffect_get_children_size()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_get_uniform_byte_size")>]
    extern void sk_runtimeeffect_get_uniform_byte_size()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_get_uniform_from_index")>]
    extern void sk_runtimeeffect_get_uniform_from_index()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_get_uniform_from_name")>]
    extern void sk_runtimeeffect_get_uniform_from_name()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_get_uniform_name")>]
    extern void sk_runtimeeffect_get_uniform_name()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_get_uniforms_size")>]
    extern void sk_runtimeeffect_get_uniforms_size()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_make_blender")>]
    extern void sk_runtimeeffect_make_blender()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_make_color_filter")>]
    extern void sk_runtimeeffect_make_color_filter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_make_for_blender")>]
    extern void sk_runtimeeffect_make_for_blender()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_make_for_color_filter")>]
    extern void sk_runtimeeffect_make_for_color_filter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_make_for_shader")>]
    extern void sk_runtimeeffect_make_for_shader()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_make_shader")>]
    extern void sk_runtimeeffect_make_shader()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_runtimeeffect_unref")>]
    extern void sk_runtimeeffect_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_blend")>]
    extern void sk_shader_new_blend()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_blender")>]
    extern void sk_shader_new_blender()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_color")>]
    extern void sk_shader_new_color()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_color4f")>]
    extern void sk_shader_new_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_empty")>]
    extern void sk_shader_new_empty()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_linear_gradient")>]
    extern void sk_shader_new_linear_gradient()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_linear_gradient_color4f")>]
    extern void sk_shader_new_linear_gradient_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_perlin_noise_fractal_noise")>]
    extern void sk_shader_new_perlin_noise_fractal_noise()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_perlin_noise_turbulence")>]
    extern void sk_shader_new_perlin_noise_turbulence()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_radial_gradient")>]
    extern void sk_shader_new_radial_gradient()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_radial_gradient_color4f")>]
    extern void sk_shader_new_radial_gradient_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_sweep_gradient")>]
    extern void sk_shader_new_sweep_gradient()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_sweep_gradient_color4f")>]
    extern void sk_shader_new_sweep_gradient_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_two_point_conical_gradient")>]
    extern void sk_shader_new_two_point_conical_gradient()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_new_two_point_conical_gradient_color4f")>]
    extern void sk_shader_new_two_point_conical_gradient_color4f()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_ref")>]
    extern void sk_shader_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_unref")>]
    extern void sk_shader_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_with_color_filter")>]
    extern void sk_shader_with_color_filter()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_shader_with_local_matrix")>]
    extern void sk_shader_with_local_matrix()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_asset_destroy")>]
    extern void sk_stream_asset_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_destroy")>]
    extern void sk_stream_destroy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_duplicate")>]
    extern void sk_stream_duplicate()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_fork")>]
    extern void sk_stream_fork()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_get_length")>]
    extern void sk_stream_get_length()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_get_memory_base")>]
    extern void sk_stream_get_memory_base()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_get_position")>]
    extern void sk_stream_get_position()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_has_length")>]
    extern void sk_stream_has_length()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_has_position")>]
    extern void sk_stream_has_position()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_is_at_end")>]
    extern void sk_stream_is_at_end()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_move")>]
    extern void sk_stream_move()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_peek")>]
    extern void sk_stream_peek()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_read")>]
    extern void sk_stream_read()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_read_bool")>]
    extern void sk_stream_read_bool()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_read_s16")>]
    extern void sk_stream_read_s16()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_read_s32")>]
    extern void sk_stream_read_s32()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_read_s8")>]
    extern void sk_stream_read_s8()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_read_u16")>]
    extern void sk_stream_read_u16()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_read_u32")>]
    extern void sk_stream_read_u32()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_read_u8")>]
    extern void sk_stream_read_u8()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_rewind")>]
    extern void sk_stream_rewind()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_seek")>]
    extern void sk_stream_seek()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_stream_skip")>]
    extern void sk_stream_skip()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_string_destructor")>]
    extern void sk_string_destructor()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_string_get_c_str")>]
    extern void sk_string_get_c_str()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_string_get_size")>]
    extern void sk_string_get_size()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_string_new_empty")>]
    extern void sk_string_new_empty()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_string_new_with_copy")>]
    extern void sk_string_new_with_copy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_draw")>]
    extern void sk_surface_draw()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_flush")>]
    extern void sk_surface_flush()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_flush_and_submit")>]
    extern void sk_surface_flush_and_submit()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_get_canvas")>]
    extern void sk_surface_get_canvas()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_get_props")>]
    extern void sk_surface_get_props()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_get_recording_context")>]
    extern void sk_surface_get_recording_context()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_new_backend_render_target")>]
    extern void sk_surface_new_backend_render_target()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_new_backend_texture")>]
    extern void sk_surface_new_backend_texture()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_new_image_snapshot")>]
    extern void sk_surface_new_image_snapshot()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_new_image_snapshot_with_crop")>]
    extern void sk_surface_new_image_snapshot_with_crop()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_new_metal_layer")>]
    extern void sk_surface_new_metal_layer()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_new_metal_view")>]
    extern void sk_surface_new_metal_view()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_new_null")>]
    extern void sk_surface_new_null()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_new_raster")>]
    extern void sk_surface_new_raster()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_new_raster_direct")>]
    extern void sk_surface_new_raster_direct()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_new_render_target")>]
    extern void sk_surface_new_render_target()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_peek_pixels")>]
    extern void sk_surface_peek_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_read_pixels")>]
    extern void sk_surface_read_pixels()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surface_unref")>]
    extern void sk_surface_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surfaceprops_delete")>]
    extern void sk_surfaceprops_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surfaceprops_get_flags")>]
    extern void sk_surfaceprops_get_flags()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surfaceprops_get_pixel_geometry")>]
    extern void sk_surfaceprops_get_pixel_geometry()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_surfaceprops_new")>]
    extern void sk_surfaceprops_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_svgcanvas_create_with_stream")>]
    extern void sk_svgcanvas_create_with_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_swizzle_swap_rb")>]
    extern void sk_swizzle_swap_rb()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_text_utils_get_path")>]
    extern void sk_text_utils_get_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_text_utils_get_pos_path")>]
    extern void sk_text_utils_get_pos_path()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_alloc_run")>]
    extern void sk_textblob_builder_alloc_run()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_alloc_run_pos")>]
    extern void sk_textblob_builder_alloc_run_pos()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_alloc_run_pos_h")>]
    extern void sk_textblob_builder_alloc_run_pos_h()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_alloc_run_rsxform")>]
    extern void sk_textblob_builder_alloc_run_rsxform()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_alloc_run_text")>]
    extern void sk_textblob_builder_alloc_run_text()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_alloc_run_text_pos")>]
    extern void sk_textblob_builder_alloc_run_text_pos()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_alloc_run_text_pos_h")>]
    extern void sk_textblob_builder_alloc_run_text_pos_h()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_alloc_run_text_rsxform")>]
    extern void sk_textblob_builder_alloc_run_text_rsxform()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_delete")>]
    extern void sk_textblob_builder_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_make")>]
    extern void sk_textblob_builder_make()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_builder_new")>]
    extern void sk_textblob_builder_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_get_bounds")>]
    extern void sk_textblob_get_bounds()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_get_intercepts")>]
    extern void sk_textblob_get_intercepts()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_get_unique_id")>]
    extern void sk_textblob_get_unique_id()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_ref")>]
    extern void sk_textblob_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_textblob_unref")>]
    extern void sk_textblob_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_copy_table_data")>]
    extern void sk_typeface_copy_table_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_count_glyphs")>]
    extern void sk_typeface_count_glyphs()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_count_tables")>]
    extern void sk_typeface_count_tables()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_create_default")>]
    extern void sk_typeface_create_default()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_create_from_data")>]
    extern void sk_typeface_create_from_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_create_from_file")>]
    extern void sk_typeface_create_from_file()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_create_from_name")>]
    extern void sk_typeface_create_from_name()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_create_from_stream")>]
    extern void sk_typeface_create_from_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_get_family_name")>]
    extern void sk_typeface_get_family_name()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_get_font_slant")>]
    extern void sk_typeface_get_font_slant()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_get_font_weight")>]
    extern void sk_typeface_get_font_weight()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_get_font_width")>]
    extern void sk_typeface_get_font_width()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_get_fontstyle")>]
    extern void sk_typeface_get_fontstyle()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_get_kerning_pair_adjustments")>]
    extern void sk_typeface_get_kerning_pair_adjustments()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_get_table_data")>]
    extern void sk_typeface_get_table_data()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_get_table_size")>]
    extern void sk_typeface_get_table_size()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_get_table_tags")>]
    extern void sk_typeface_get_table_tags()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_get_units_per_em")>]
    extern void sk_typeface_get_units_per_em()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_is_fixed_pitch")>]
    extern void sk_typeface_is_fixed_pitch()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_open_stream")>]
    extern void sk_typeface_open_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_ref_default")>]
    extern void sk_typeface_ref_default()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_unichar_to_glyph")>]
    extern void sk_typeface_unichar_to_glyph()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_unichars_to_glyphs")>]
    extern void sk_typeface_unichars_to_glyphs()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_typeface_unref")>]
    extern void sk_typeface_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_version_get_increment")>]
    extern void sk_version_get_increment()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_version_get_milestone")>]
    extern void sk_version_get_milestone()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_version_get_string")>]
    extern void sk_version_get_string()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_vertices_make_copy")>]
    extern void sk_vertices_make_copy()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_vertices_ref")>]
    extern void sk_vertices_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_vertices_unref")>]
    extern void sk_vertices_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_webpencoder_encode")>]
    extern void sk_webpencoder_encode()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_bytes_written")>]
    extern void sk_wstream_bytes_written()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_flush")>]
    extern void sk_wstream_flush()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_get_size_of_packed_uint")>]
    extern void sk_wstream_get_size_of_packed_uint()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_newline")>]
    extern void sk_wstream_newline()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write")>]
    extern void sk_wstream_write()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_16")>]
    extern void sk_wstream_write_16()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_32")>]
    extern void sk_wstream_write_32()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_8")>]
    extern void sk_wstream_write_8()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_bigdec_as_text")>]
    extern void sk_wstream_write_bigdec_as_text()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_bool")>]
    extern void sk_wstream_write_bool()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_dec_as_text")>]
    extern void sk_wstream_write_dec_as_text()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_hex_as_text")>]
    extern void sk_wstream_write_hex_as_text()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_packed_uint")>]
    extern void sk_wstream_write_packed_uint()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_scalar")>]
    extern void sk_wstream_write_scalar()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_scalar_as_text")>]
    extern void sk_wstream_write_scalar_as_text()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_stream")>]
    extern void sk_wstream_write_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "sk_wstream_write_text")>]
    extern void sk_wstream_write_text()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_builder_delete")>]
    extern void skottie_animation_builder_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_builder_get_stats")>]
    extern void skottie_animation_builder_get_stats()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_builder_make_from_data")>]
    extern void skottie_animation_builder_make_from_data()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_builder_make_from_file")>]
    extern void skottie_animation_builder_make_from_file()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_builder_make_from_stream")>]
    extern void skottie_animation_builder_make_from_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_builder_make_from_string")>]
    extern void skottie_animation_builder_make_from_string()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_builder_new")>]
    extern void skottie_animation_builder_new()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_builder_set_font_manager")>]
    extern void skottie_animation_builder_set_font_manager()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_builder_set_resource_provider")>]
    extern void skottie_animation_builder_set_resource_provider()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_delete")>]
    extern void skottie_animation_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_get_duration")>]
    extern void skottie_animation_get_duration()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_get_fps")>]
    extern void skottie_animation_get_fps()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_get_in_point")>]
    extern void skottie_animation_get_in_point()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_get_out_point")>]
    extern void skottie_animation_get_out_point()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_get_size")>]
    extern void skottie_animation_get_size()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_get_version")>]
    extern void skottie_animation_get_version()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_make_from_data")>]
    extern void skottie_animation_make_from_data()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_make_from_file")>]
    extern void skottie_animation_make_from_file()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_make_from_stream")>]
    extern void skottie_animation_make_from_stream()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_make_from_string")>]
    extern void skottie_animation_make_from_string()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_ref")>]
    extern void skottie_animation_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_render")>]
    extern void skottie_animation_render()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_render_with_flags")>]
    extern void skottie_animation_render_with_flags()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_seek")>]
    extern void skottie_animation_seek()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_seek_frame")>]
    extern void skottie_animation_seek_frame()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_seek_frame_time")>]
    extern void skottie_animation_seek_frame_time()
    [<DllImport("libSkiaSharp", EntryPoint = "skottie_animation_unref")>]
    extern void skottie_animation_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "skresources_caching_resource_provider_proxy_make")>]
    extern void skresources_caching_resource_provider_proxy_make()
    [<DllImport("libSkiaSharp", EntryPoint = "skresources_data_uri_resource_provider_proxy_make")>]
    extern void skresources_data_uri_resource_provider_proxy_make()
    [<DllImport("libSkiaSharp", EntryPoint = "skresources_file_resource_provider_make")>]
    extern void skresources_file_resource_provider_make()
    [<DllImport("libSkiaSharp", EntryPoint = "skresources_resource_provider_delete")>]
    extern void skresources_resource_provider_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "skresources_resource_provider_load")>]
    extern void skresources_resource_provider_load()
    [<DllImport("libSkiaSharp", EntryPoint = "skresources_resource_provider_load_audio_asset")>]
    extern void skresources_resource_provider_load_audio_asset()
    [<DllImport("libSkiaSharp", EntryPoint = "skresources_resource_provider_load_image_asset")>]
    extern void skresources_resource_provider_load_image_asset()
    [<DllImport("libSkiaSharp", EntryPoint = "skresources_resource_provider_load_typeface")>]
    extern void skresources_resource_provider_load_typeface()
    [<DllImport("libSkiaSharp", EntryPoint = "skresources_resource_provider_ref")>]
    extern void skresources_resource_provider_ref()
    [<DllImport("libSkiaSharp", EntryPoint = "skresources_resource_provider_unref")>]
    extern void skresources_resource_provider_unref()
    [<DllImport("libSkiaSharp", EntryPoint = "sksg_invalidation_controller_begin")>]
    extern void sksg_invalidation_controller_begin()
    [<DllImport("libSkiaSharp", EntryPoint = "sksg_invalidation_controller_delete")>]
    extern void sksg_invalidation_controller_delete()
    [<DllImport("libSkiaSharp", EntryPoint = "sksg_invalidation_controller_end")>]
    extern void sksg_invalidation_controller_end()
    [<DllImport("libSkiaSharp", EntryPoint = "sksg_invalidation_controller_get_bounds")>]
    extern void sksg_invalidation_controller_get_bounds()
    [<DllImport("libSkiaSharp", EntryPoint = "sksg_invalidation_controller_inval")>]
    extern void sksg_invalidation_controller_inval()
    [<DllImport("libSkiaSharp", EntryPoint = "sksg_invalidation_controller_new")>]
    extern void sksg_invalidation_controller_new()
    [<DllImport("libSkiaSharp", EntryPoint = "sksg_invalidation_controller_reset")>]
    extern void sksg_invalidation_controller_reset()
