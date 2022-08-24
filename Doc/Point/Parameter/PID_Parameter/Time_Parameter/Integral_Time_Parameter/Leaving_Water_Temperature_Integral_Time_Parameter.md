[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Time_Parameter](../Time_Parameter.md) > [Integral_Time_Parameter](Integral_Time_Parameter.md) > [Leaving_Water_Temperature_Integral_Time_Parameter](.)
# Leaving_Water_Temperature_Integral_Time_Parameter

**Display name:** Leaving Water Temperature Integral Time Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Water_Temperature_Integral_Time_Parameter;1

---
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
