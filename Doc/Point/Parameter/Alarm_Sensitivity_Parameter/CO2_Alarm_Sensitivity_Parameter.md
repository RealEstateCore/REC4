[Point](../../Point.md) > [Parameter](../Parameter.md) > [Alarm_Sensitivity_Parameter](Alarm_Sensitivity_Parameter.md) > [CO2_Alarm_Sensitivity_Parameter](.)
# CO2_Alarm_Sensitivity_Parameter
**DTMI:** dtmi:org:brickschema:schema:Brick:CO2_Alarm_Sensitivity_Parameter;1
## Display name
- **en:** CO2 Alarm Sensitivity Parameter
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
