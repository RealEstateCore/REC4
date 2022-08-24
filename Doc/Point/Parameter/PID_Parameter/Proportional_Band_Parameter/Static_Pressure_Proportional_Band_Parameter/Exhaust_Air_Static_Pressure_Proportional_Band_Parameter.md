[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Proportional_Band_Parameter](../Proportional_Band_Parameter.md) > [Static_Pressure_Proportional_Band_Parameter](Static_Pressure_Proportional_Band_Parameter.md) > [Exhaust_Air_Static_Pressure_Proportional_Band_Parameter](.)
# Exhaust_Air_Static_Pressure_Proportional_Band_Parameter
**DTMI:** dtmi:org:brickschema:schema:Brick:Exhaust_Air_Static_Pressure_Proportional_Band_Parameter;1
## Display name
- **en:** Exhaust Air Static Pressure Proportional Band Parameter
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint